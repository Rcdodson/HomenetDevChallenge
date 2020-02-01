using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnswerProgram
{
	public class Program
	{
		private const string URL = "http://api.coxauto-interview.com/";

		static void Main(string[] args)
		{
			Answer answer = new Answer();
			List<DealerAnswer> dealerAnswers = new List<DealerAnswer>();			
			Dictionary<int?, List<VehicleAnswer>> dict = new Dictionary<int?, List<VehicleAnswer>>();
			HashSet<DealersResponse> DealerList = new HashSet<DealersResponse>();

			Configuration config = new Configuration(new Dictionary<string, string>(), new Dictionary<string, string>(), 
				new Dictionary<string, string>(), basePath: URL);

			DataSetApi dataSetApi = new DataSetApi(config);
			DealersApi dealerApi = new DealersApi(config);
			VehiclesApi vehiclesApi = new VehiclesApi(config);

            var datasetId = dataSetApi.GetDataSetId().DatasetId;
            var vehiclesTask = vehiclesApi.GetIdsAsync(datasetId);
            var dealersTask = dealerApi.GetDealerAsync(datasetId, vehiclesTask.Result.VehicleIds.Count);

            var vehicleIds = await vehiclesTask;
            var dealerIds = await dealersTask;

            /*
			foreach (int v in vehicleIds.VehicleIds)
			{
				VehicleResponse vehicleInfo = vehiclesApi.GetVehicle(datasetId, v);
				DealersResponse dealersResponse = dealerApi.GetDealer(datasetId, vehicleInfo.DealerId);
				var dealerId = dealersResponse.DealerId;

				VehicleAnswer vehicleAnswer = new VehicleAnswer();
				vehicleAnswer.Year = vehicleInfo.Year;
				vehicleAnswer.Make = vehicleInfo.Make;
				vehicleAnswer.Model = vehicleInfo.Model;
				vehicleAnswer.VehicleId = vehicleInfo.VehicleId;

				//dealer is in dictionary
				if (dict.ContainsKey(dealerId))
				{
					//get vehicle answers
					List<VehicleAnswer> vAs = dict[dealerId];
					//add new answer
					vAs.Add(vehicleAnswer);
					//add new answer list
					dict[dealerId] = vAs;
				}
				//dealer is not in dictionary
				else
				{
					List<VehicleAnswer> vAs = new List<VehicleAnswer>();
					vAs.Add(vehicleAnswer);
					dict.Add(dealerId, vAs);
				}

				DealerList.Add(dealersResponse);
			}

			foreach(var d in DealerList)
			{
				DealerAnswer dealerAnswer = new DealerAnswer();
				dealerAnswer.DealerId = d.DealerId;
				dealerAnswer.Name = d.Name;
				dealerAnswer.Vehicles = dict[d.DealerId];

				dealerAnswers.Add(dealerAnswer);
			}
			answer.Dealers = dealerAnswers;

			AnswerResponse finalAnswer = dataSetApi.PostAnswer(datasetId, answer);

			Console.WriteLine(finalAnswer.ToJson());
            Console.ReadLine();*/
		}
	}
}
