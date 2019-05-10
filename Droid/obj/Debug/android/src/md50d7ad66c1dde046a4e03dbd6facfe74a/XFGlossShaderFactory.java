package md50d7ad66c1dde046a4e03dbd6facfe74a;


public class XFGlossShaderFactory
	extends android.graphics.drawable.ShapeDrawable.ShaderFactory
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_resize:(II)Landroid/graphics/Shader;:GetResize_IIHandler\n" +
			"";
		mono.android.Runtime.register ("XFGloss.Droid.Drawables.XFGlossShaderFactory, XFGloss.Droid", XFGlossShaderFactory.class, __md_methods);
	}


	public XFGlossShaderFactory ()
	{
		super ();
		if (getClass () == XFGlossShaderFactory.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Drawables.XFGlossShaderFactory, XFGloss.Droid", "", this, new java.lang.Object[] {  });
	}


	public android.graphics.Shader resize (int p0, int p1)
	{
		return n_resize (p0, p1);
	}

	private native android.graphics.Shader n_resize (int p0, int p1);

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
