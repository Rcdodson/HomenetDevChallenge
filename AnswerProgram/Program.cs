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

        public static void Main(string[] args)
		{
			Answer answer = new Answer();
			List<DealerAnswer> dealerAnswers = new List<DealerAnswer>();			
			Dictionary<int?, List<VehicleAnswer>> dict = new Dictionary<int?, List<VehicleAnswer>>();

			Configuration config = new Configuration(new Dictionary<string, string>(), new Dictionary<string, string>(), 
				new Dictionary<string, string>(), basePath: URL);

			DataSetApi dataSetApi = new DataSetApi(config);
			DealersApi dealerApi = new DealersApi(config);
			VehiclesApi vehiclesApi = new VehiclesApi(config);

            var datasetId = dataSetApi.GetDataSetId().DatasetId;
            var vehiclesIds = vehiclesApi.GetIds(datasetId);

            List<Task<VehicleResponse>> vehicletasks = new List<Task<VehicleResponse>>();
            foreach(var v in vehiclesIds.VehicleIds)
            {
                vehicletasks.Add(vehiclesApi.GetVehicleAsync(datasetId, v));
            }

            Task.WaitAll(vehicletasks.ToArray());

            foreach (var v in vehicletasks)
            {

                VehicleAnswer vehicleAnswer = new VehicleAnswer
                {
                    Year = v.Result.Year,
                    Make = v.Result.Make,
                    Model = v.Result.Model,
                    VehicleId = v.Result.VehicleId
                };

                //dealer is in dictionary
                if (dict.ContainsKey(v.Result.DealerId))
                {
                    //get vehicle answers
                    List<VehicleAnswer> vAs = dict[v.Result.DealerId];
                    //add new answer
                    vAs.Add(vehicleAnswer);
                    //add new answer list
                    dict[v.Result.DealerId] = vAs;
                }
                //dealer is not in dictionary
                else
                {
                    List<VehicleAnswer> vAs = new List<VehicleAnswer>();
                    vAs.Add(vehicleAnswer);
                    dict.Add(v.Result.DealerId, vAs);
                }
            }

            List<Task<DealersResponse>> dealertasks = new List<Task<DealersResponse>>();
            foreach(var v in dict)
            {
                dealertasks.Add(dealerApi.GetDealerAsync(datasetId, v.Key));
            }

            Task.WaitAll(dealertasks.ToArray());

            foreach(var d in dealertasks)
            {
                DealerAnswer dealerAnswer = new DealerAnswer
                {
                    DealerId = d.Result.DealerId,
                    Name = d.Result.Name,
                    Vehicles = dict[d.Result.DealerId]
                };

                dealerAnswers.Add(dealerAnswer);
            }

            answer.Dealers = dealerAnswers;

            AnswerResponse finalAnswer = dataSetApi.PostAnswer(datasetId, answer);
            Console.WriteLine(finalAnswer.ToJson());
            Console.ReadLine();
        }
    }
}
