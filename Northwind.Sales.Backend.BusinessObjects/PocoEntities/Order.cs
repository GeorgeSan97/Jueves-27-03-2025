using Northwind.Sales.Backend.BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Sales.Backend.BusinessObjects.PocoEntities;

public class Order
{
	public int Id { get; set; }
	public string CustomerId { get; set; }
	public string ShipAddres { get; set; }
	public string ShipCity { get; set; }
	public string ShipCountry { get; set; }
	public string ShipPostalCode { get; set; }
	public ShippingType ShippingType { get; set; }
	public DisccountType DisccountType { get; set; }
	
}
