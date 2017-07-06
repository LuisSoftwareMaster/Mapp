using System;

namespace PorpoiseMobileApp
{
	public interface IDirty
	{
		bool IsDirty{get;}
		void Cleanup();
	}
}

