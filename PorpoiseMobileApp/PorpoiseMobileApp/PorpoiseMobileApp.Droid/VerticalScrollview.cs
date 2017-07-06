using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using PorpoiseMobileApp.Droid;
using System.Collections.Generic;



namespace verticalscrollviewandroid
{

    public class VerticalScrollview : ScrollView
{


    public VerticalScrollview(Context context): base(context, null)
    {

    }

    public VerticalScrollview(Context context, IAttributeSet attrs): base(context, attrs)
    {

    }

    public VerticalScrollview(Context context, IAttributeSet attrs, int defStyle): base (context, attrs, defStyle)
    {
       
    }

    
        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {

            int action = ev.ActionIndex;
            switch (ev.Action)
        {
                case MotionEventActions.Down:
                //Log.i("VerticalScrollview", "onInterceptTouchEvent: DOWN super false");
                base.OnTouchEvent(ev);
                break;

                case MotionEventActions.Move:
                return false; // redirect MotionEvents to ourself

            case MotionEventActions.Cancel:
                //Log.i("VerticalScrollview", "onInterceptTouchEvent: CANCEL super false");
                    base.OnTouchEvent(ev);
                break;

            case MotionEventActions.Up:
                //Log.i("VerticalScrollview", "onInterceptTouchEvent: UP super false");
                return false;

            
        }

        return false;
    }

   
    public override bool OnTouchEvent(MotionEvent ev)
    {
        base.OnTouchEvent(ev);
        //Log.i("VerticalScrollview", "onTouchEvent. action: " + ev.getAction());
        return true;
    }
}

}