
namespace BeatThat
{
	/// <summary>
	/// Assets that have been downloaded generally get disposed via UnityEngine.Object.DestroyImmediate
	/// </summary>
	public class DownloadedAssetDisposable<T> : Disposable<T> where T : class
	{
		public DownloadedAssetDisposable(T item)
		{
			this.item = item;
		}

		public T item { get; private set; } 

		public void DisposeItem()
		{
			if(this.item == null) {
				return;
			}

			var uObj = this.item as UnityEngine.Object;
			this.item = null;
			if(uObj != null) {
				UnityEngine.Object.DestroyImmediate(uObj);
			}
		}
	}
}