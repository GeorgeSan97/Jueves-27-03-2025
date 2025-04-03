using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Sales.Entities.Dtos.CreateOrder
{
	//public class CreateOrderDto(string customerId, string ahipAddress, 
	//	string shipCity, string shipCountry, string shipPostalCode, 
	//	IEnumerable<CreateOrderDetailDto> orderDetails)
	//{
	//	public string CustomerId => customerId;
	//	public string ShipAddress => ahipAddress;
	//	public string ShipCity => shipCity;
	//	public string ShipCountry => shipCountry;
	//	public string ShipPostalCode => shipPostalCode;
	//	public IEnumerable<CreateOrderDetailDto> OrderDetails => orderDetails;
	//}

	public class CreateOrderDto
	{
		private readonly string _customerId;
		private readonly string _shipAddress;
		private readonly string _shipCity;
		private readonly string _shipCountry;
		private readonly string _shipPostalCode;
		private readonly IEnumerable<CreateOrderDetailDto> _orderDetails;

		public string CustomerId { get { return _customerId; } }
		public string ShipAddress { get { return _shipAddress; } }
		public string ShipCity { get { return _shipCity; } }
		public string ShipCountry { get { return _shipCountry; } }
		public string ShipPostalCode { get { return _shipPostalCode; } }
		public IEnumerable<CreateOrderDetailDto> OrderDetails { get { return _orderDetails; } }

		public CreateOrderDto(string customerId, string shipAddress, string shipCity, string shipCountry, string shipPostalCode, IEnumerable<CreateOrderDetailDto> orderDetails)
		{
			_customerId = customerId;
			_shipAddress = shipAddress;
			_shipCity = shipCity;
			_shipCountry = shipCountry;
			_shipPostalCode = shipPostalCode;
			_orderDetails = orderDetails;
		}
	}
}
