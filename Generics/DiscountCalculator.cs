namespace Generics
{
	public class DiscountCalculator<TProduct> where TProduct : Product
	{
		public double CalcluteDiscount(TProduct product)
		{
			product.Price -= (0.2 * product.Price);

			return product.Price;
		}
	}
}