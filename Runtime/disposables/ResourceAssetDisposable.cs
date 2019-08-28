using UnityEngine;


namespace BeatThat.Disposables
{
	public class ResourceAssetDisposable<T> : Disposable<T> where T : class
	{
		public ResourceAssetDisposable(T item)
		{
			this.item = item;
		}

		public T item { get; set; }

        public void Dispose()
        {
            DisposeItem();
        }

        public void DisposeItem()
		{
			if(this.item == null) {
				return;
			}

			var obj = this.item as UnityEngine.Object;
			this.item = null;

			// NOTE: handling of Dispose/Cancel is wrong (dispose should not unload asset)?

			// only unload if the object type is a file asset, e.g. a texure or audio file
			if(obj != null && !(obj is GameObject) && !(obj is Component)) {
				Resources.UnloadAsset(obj);
			}
		}
	}
}