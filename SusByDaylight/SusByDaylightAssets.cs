using System;
using System.Collections.Generic;
using UnityEngine;

namespace SusByDaylight
{
    // ---------------------------------------------------------
    // 1. The Abstract Base Class
    // (If Mira API already defines this for you, you can actually 
    // delete this block and just rely on their version!)
    // ---------------------------------------------------------
    public abstract class LoadableAsset<T> where T : UnityEngine.Object
    {
        protected T? LoadedAsset { get; set; }
        public abstract T LoadAsset();
    }

    // ---------------------------------------------------------
    // 2. Your Concrete Implementation
    // Because the class above is abstract, we must make a "real" 
    // version of it to load a specific type of object, like a Sprite.
    // ---------------------------------------------------------
    public class SusSpriteAsset : LoadableAsset<Sprite>
    {
        public override Sprite LoadAsset()
        {
            // Your logic to load the asset goes here 
            // (e.g., pulling it from a Unity AssetBundle)

            if (LoadedAsset == null)
            {
                // LoadedAsset = MyAssetBundle.LoadAsset<Sprite>("MySprite");
            }

            return LoadedAsset;
        }
    }
    internal class SusByDaylightAssets
    {
        // Store your assets as static properties so you can call them 
        // from anywhere like this: SusByDaylightAssets.KillerIcon.LoadAsset()
        public static List<SusSpriteAsset> AllAssets { get; } = new()
        {

        };
    }
}