using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnswerProgram
{
    static class Program
	{
		private const string URL = "http://api.coxauto-interview.com/";

		public static async Task Main(string[] args)
		{
			Answer answer = new Answer();
			HashSet<DealerAnswer> dealerAnswers = new HashSet<DealerAnswer>();			
			Dictionary<int?, List<VehicleAnswer>> dict = new Dictionary<int?, List<VehicleAnswer>>();

			Configuration config = new Configuration(new Dictionary<string, string>(), new Dictionary<string, string>(), 
				new Dictionary<string, string>(), basePath: URL);

			DataSetApi dataSetApi = new DataSetApi(config);
			DealersApi dealerApi = new DealersApi(config);
			VehiclesApi vehiclesApi = new VehiclesApi(config);

            var datasetId = dataSetApi.GetDataSetId().DatasetId;
            var vehiclesTask = vehiclesApi.GetIdsAsync(datasetId);

            foreach(var v in vehiclesTask.Result.VehicleIds)
            {
                var vehicleInfoTask = vehiclesApi.GetVehicleAsync(datasetId, v);
                var dealersTask = dealerApi.GetDealerAsync(datasetId, vehicleInfoTask.Result.DealerId);

                VehicleAnswer vehicleAnswer = new VehicleAnswer();
                vehicleAnswer.Year = vehicleInfoTask.Result.Year;
                vehicleAnswer.Make = vehicleInfoTask.Result.Make;
                vehicleAnswer.Model = vehicleInfoTask.Result.Model;
                vehicleAnswer.VehicleId = vehicleInfoTask.Result.VehicleId;

                //dealer is in dictionary
                if (dict.ContainsKey(dealersTask.Result.DealerId))
                {
                    //get vehicle answers
                    List<VehicleAnswer> vAs = dict[dealersTask.Result.DealerId];
                    //add new answer
                    vAs.Add(vehicleAnswer);
                    //add new answer list
                    dict[dealersTask.Result.DealerId] = vAs;
                }
                //dealer is not in dictionary
                else
                {
                    List<VehicleAnswer> vAs = new List<VehicleAnswer>();
                    vAs.Add(vehicleAnswer);
                    dict.Add(dealersTask.Result.DealerId, vAs);
                }

                DealerAnswer dealerAnswer = new DealerAnswer();
                dealerAnswer.DealerId = dealersTask.Result.DealerId;
                dealerAnswer.Name = dealersTask.Result.Name;
                dealerAnswer.Vehicles = dict[dealersTask.Result.DealerId];
                dealerAnswers.Add(dealerAnswer);

                List<DealerAnswer> das = new List<DealerAnswer>(dealerAnswers);
                answer.Dealers = das;
            }

            AnswerResponse finalAnswer = dataSetApi.PostAnswer(datasetId, answer);
            Console.WriteLine(finalAnswer.ToJson());
            Console.ReadLine();
        }
	}
}
