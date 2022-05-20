﻿//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Crowbar
{
	public class FlexFrame
	{

		public string flexName;
		public string flexDescription;
		public bool flexHasPartner;
		public string flexPartnerName;
		public double flexSplit;
		public List<int> bodyAndMeshVertexIndexStarts;
		public List<SourceMdlFlex> flexes;
		public List<int> meshIndexes;

	}

}