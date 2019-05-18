
namespace Framework
{
	abstract class Factory
	{
		public IProduct Create(string owner)
		{
			var p = createProduct(owner);
			registerProduct(p);

			return p;
		}

		protected abstract IProduct createProduct(string owner);
		protected abstract void registerProduct(IProduct product);
	}
}
