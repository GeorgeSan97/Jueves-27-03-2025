using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Sales.Entities.Dtos.CreateOrder;

//Constructores primarios
public class CreateOrderDetailDto (int productoId, 
	decimal unitPrice, short quantity)
{
	public int ProductId => productoId;
	public decimal UnitPrice => unitPrice;
	public short Quantity => quantity;
}

//public class CreateOrderDto
//{	
//	private readonly int _productId;
//	private readonly decimal _unitPrice;
//	private readonly short _quantity;	

//	public int ProductId { get { return _productId; } }

//	public decimal UnitPrice { get { return _unitPrice; } }

//	public short Quantity { get { return _quantity; } }

//	public CreateOrderDto(int productId, decimal unitPrice, short quantity)
//	{
//		_productId = productId;
//		_unitPrice = unitPrice;
//		_quantity = quantity;
//	}

//}


