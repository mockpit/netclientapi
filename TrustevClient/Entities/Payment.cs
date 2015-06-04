
// Generated by ApiCrawler

using System;
using Trustev.Api.Client.Entities;
using Newtonsoft.Json;

namespace Trustev.Api.Client.Entities {

		
	/// <summary>
	/// 
	/// </summary>
	public class Payment {

		#region Public properties

				
		/// <summary>
		/// This is the Payment Id. This Id is returned when a Payment has been added.		/// This Id is required should you wish to update the Payment details after a Trustev Case has been added.		/// Please note: this Id is always returned from the Trustev API as a reference Id to the specific object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public System.Guid? Id;
		
		/// <summary>
		/// The type of Payment method used
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PaymentType PaymentType;
		
		/// <summary>
		/// The BIN Number - the first 6 digits of a Debit/Credit Card Number.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BINNumber;

		
		#endregion
		
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="jsonObject">JSON string defines object</param>
		public Payment(string jsonObject = null) {
		if(jsonObject!=null) {
				var desObj = JsonConvert.DeserializeObject<Payment>(jsonObject);
				this.Id = desObj.Id;
				this.PaymentType = desObj.PaymentType;
				this.BINNumber = desObj.BINNumber;
			}
		}

		#endregion
	}
}

