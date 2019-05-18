using System;
using Framework;
using System.Collections.Generic;

namespace IdCard
{
	class IDCardFactory : Factory
	{
		Dictionary<int, string> database = new Dictionary<int, string>();

		protected override IProduct createProduct(string owner)
		{
			return new IDCard(owner);
		}

		protected override void registerProduct(IProduct product)
		{
			var idCard = product as IDCard;

			database[idCard.Id] = idCard.Owner;
		}
	}
}
