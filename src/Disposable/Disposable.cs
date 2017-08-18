
namespace BeatThat
{
	public interface Disposable<T> where T : class
	{
		T item { get; } 

		void DisposeItem();
	}
}