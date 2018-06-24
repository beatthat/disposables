

namespace BeatThat.Disposables
{
	/// <summary>
	/// For assets assigned as a property to a monobehaviour.
	/// They don't need to be explicitly unloaded or destroyed. 
	/// </summary>
	public class ProjectAssetDisposable<T> : Disposable<T> where T : class
	{
		public ProjectAssetDisposable(T item)
		{
			this.item = item;
		}

		public T item { get; set; } 

		public void DisposeItem()
		{
			this.item = null;
		}
	}
}