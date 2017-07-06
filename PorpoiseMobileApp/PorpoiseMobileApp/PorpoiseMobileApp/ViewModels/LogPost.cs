using System;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp
{
	public static class LogPost
	{
		public static byte[]image;

		public static Goal goal;

		public static string highlight;

		public static string action;

		public static bool isEditing = false;

		public static Client.GetPostResponseModel editingPost;

		public static bool photoChanged;

        public static bool photoTaken = false;

        public static bool imageChanged = false;

		public static void clear(){

			image = null;

			goal = null;

			isEditing = false;

			editingPost = null;

			photoChanged = false;

			action = "";

			highlight = "";

            photoTaken = true;

            imageChanged = false;

		}

	}
}
