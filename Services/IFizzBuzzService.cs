using System.Collections.Generic;

namespace FizzBuzz
{
	public interface IFizzBuzzService
	{
		List<string> CalculateFizzBuzz(List<object> inputArray);
	}
}

