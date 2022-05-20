﻿//----------------------------------------------------------------------------------------
//	Copyright © 2003 - 2022 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This file replicates the behavior of VB's My.Application when the original VB project
//	did not include an autogenerated My.Application class.
//
//	Note: A reference to the Microsoft.VisualBasic assembly is required.
//----------------------------------------------------------------------------------------

namespace CrowbarSteamPipe.My
{
	internal sealed class MyApplication : Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase
	{
		private static readonly MyApplication instance = new MyApplication();

		static MyApplication()
		{
		}

		[global::System.Diagnostics.DebuggerStepThroughAttribute()]
		private MyApplication() : base()
		{
		}

		public static MyApplication Application
		{
			get
			{
				return instance;
			}
		}
	}
}