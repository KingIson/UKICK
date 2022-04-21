package md580d0a31d2145b2dca26649143a4fa59a;


public class CustomMediaRouterCallback
	extends android.media.MediaRouter.SimpleCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRouteVolumeChanged:(Landroid/media/MediaRouter;Landroid/media/MediaRouter$RouteInfo;)V:GetOnRouteVolumeChanged_Landroid_media_MediaRouter_Landroid_media_MediaRouter_RouteInfo_Handler\n" +
			"";
		mono.android.Runtime.register ("VolumeSliderPlugin.Droid.CustomMediaRouterCallback, VolumeSliderPlugin", CustomMediaRouterCallback.class, __md_methods);
	}


	public CustomMediaRouterCallback ()
	{
		super ();
		if (getClass () == CustomMediaRouterCallback.class)
			mono.android.TypeManager.Activate ("VolumeSliderPlugin.Droid.CustomMediaRouterCallback, VolumeSliderPlugin", "", this, new java.lang.Object[] {  });
	}


	public void onRouteVolumeChanged (android.media.MediaRouter p0, android.media.MediaRouter.RouteInfo p1)
	{
		n_onRouteVolumeChanged (p0, p1);
	}

	private native void n_onRouteVolumeChanged (android.media.MediaRouter p0, android.media.MediaRouter.RouteInfo p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
