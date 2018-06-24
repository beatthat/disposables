
namespace BeatThat.Disposables
{
	/// <summary>
	/// interface for wrapping assets in a container that knows how to dispose them, e.g. Disposable<Texture2D>
	/// </summary>
	public interface Disposable<T> where T : class
	{
		T item { get; } 

		void DisposeItem();
	}
}