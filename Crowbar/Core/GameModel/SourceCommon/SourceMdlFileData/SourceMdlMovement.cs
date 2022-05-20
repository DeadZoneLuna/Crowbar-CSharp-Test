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
	public class SourceMdlMovement
	{

		//FROM: SourceEngine2007\src_main\public\studio.h
		//struct mstudiomovement_t
		//{
		//	DECLARE_BYTESWAP_DATADESC();
		//	int					endframe;				
		//	int					motionflags;
		//	float				v0;			// velocity at start of block
		//	float				v1;			// velocity at end of block
		//	float				angle;		// YAW rotation at end of this blocks movement
		//	Vector				vector;		// movement vector relative to this blocks initial angle
		//	Vector				position;	// relative to start of animation???

		//	mstudiomovement_t(){}
		//private:
		//	// No copy constructors allowed
		//	mstudiomovement_t(const mstudiomovement_t& vOther);
		//};


		public int endframeIndex;
		public int motionFlags;
		public double v0;
		public double v1;
		public double angle;
		public SourceVector vector;
		public SourceVector position;

		//// motion flags
		//#define STUDIO_X		0x00000001
		//#define STUDIO_Y		0x00000002	
		//#define STUDIO_Z		0x00000004
		//#define STUDIO_XR		0x00000008
		//#define STUDIO_YR		0x00000010
		//#define STUDIO_ZR		0x00000020
		//
		//#define STUDIO_LX		0x00000040
		//#define STUDIO_LY		0x00000080
		//#define STUDIO_LZ		0x00000100
		//#define STUDIO_LXR		0x00000200
		//#define STUDIO_LYR		0x00000400
		//#define STUDIO_LZR		0x00000800
		//
		//#define STUDIO_LINEAR	0x00001000
		//#define STUDIO_QUADRATIC_MOTION 0x00002000

		public const int STUDIO_X = 0x1;
		public const int STUDIO_Y = 0x2;
		public const int STUDIO_Z = 0x4;
		public const int STUDIO_XR = 0x8;
		public const int STUDIO_YR = 0x10;
		public const int STUDIO_ZR = 0x20;

		public const int STUDIO_LX = 0x40;
		public const int STUDIO_LY = 0x80;
		public const int STUDIO_LZ = 0x100;
		public const int STUDIO_LXR = 0x200;
		public const int STUDIO_LYR = 0x400;
		public const int STUDIO_LZR = 0x800;

		public const int STUDIO_LINEAR = 0x1000;
		public const int STUDIO_QUADRATIC_MOTION = 0x2000;

		//int lookupControl( char *string )
		//{
		//	if (stricmp(string,"X")==0) return STUDIO_X;
		//	if (stricmp(string,"Y")==0) return STUDIO_Y;
		//	if (stricmp(string,"Z")==0) return STUDIO_Z;
		//	if (stricmp(string,"XR")==0) return STUDIO_XR;
		//	if (stricmp(string,"YR")==0) return STUDIO_YR;
		//	if (stricmp(string,"ZR")==0) return STUDIO_ZR;
		//
		//	if (stricmp(string,"LX")==0) return STUDIO_LX;
		//	if (stricmp(string,"LY")==0) return STUDIO_LY;
		//	if (stricmp(string,"LZ")==0) return STUDIO_LZ;
		//	if (stricmp(string,"LXR")==0) return STUDIO_LXR;
		//	if (stricmp(string,"LYR")==0) return STUDIO_LYR;
		//	if (stricmp(string,"LZR")==0) return STUDIO_LZR;
		//
		//	if (stricmp(string,"LM")==0) return STUDIO_LINEAR;
		//	if (stricmp(string,"LQ")==0) return STUDIO_QUADRATIC_MOTION;
		//
		//	return -1;
		//}

	}

}