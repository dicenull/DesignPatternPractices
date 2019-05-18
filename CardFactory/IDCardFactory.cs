using System;
using Framework;
using System.Collections.Generic;

namespace IdCard
{
	class IDCardFactory : Factory
	{
		List<string> Owners { get; } = new List<string>();

		protected override IProduct createProduct(string owner)
		{
			return new IDCard(owner);
		}

		protected override void registerProduct(IProduct product)
		{
			Owners.Add((product as IDCard).Owner);
		}
	}
}
