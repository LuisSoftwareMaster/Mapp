﻿using System;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.Client
{
	public class GetPostResponseModel : ResponseModel<HourLog>
	{
		public GetPostResponseModel()
		{

		}

		public GetPostResponseModel(bool successful) : base(successful)
        {

		}
	}
}

