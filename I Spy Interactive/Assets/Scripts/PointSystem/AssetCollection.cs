using System.Collections.Generic;
using UnityEngine;

public class AssetCollection : MonoBehaviour
{
   public List<Assets> assetList;

   public void AddAsset(Assets assetObj)
   {
       if (!assetList.Contains(assetObj))
       {
           assetList.Add(assetObj);
       }
   }

   public void UseAsset()
   {
       assetList[0].UpdateImage();
       assetList.RemoveAt(0);
   }

   public void UpgradeAssets(int value)
   {
       foreach (var assetObj in assetList)
       {
           assetObj.value = value;
       }
   }
}
