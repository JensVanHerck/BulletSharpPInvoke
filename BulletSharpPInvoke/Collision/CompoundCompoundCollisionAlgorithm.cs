using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BulletSharp
{
	public class CompoundCompoundCollisionAlgorithm : CompoundCollisionAlgorithm
	{
		public new class CreateFunc : CollisionAlgorithmCreateFunc
		{
			internal CreateFunc(IntPtr native)
				: base(native, true)
			{
			}

			public CreateFunc()
				: base(btCompoundCompoundCollisionAlgorithm_CreateFunc_new(), false)
			{
			}

            public override CollisionAlgorithm CreateCollisionAlgorithm(CollisionAlgorithmConstructionInfo __unnamed0, CollisionObjectWrapper body0Wrap, CollisionObjectWrapper body1Wrap)
            {
                return new CompoundCompoundCollisionAlgorithm(btCollisionAlgorithmCreateFunc_CreateCollisionAlgorithm(
                    _native, __unnamed0._native, body0Wrap._native, body1Wrap._native));
            }

			[DllImport(Native.Dll, CallingConvention = Native.Conv), SuppressUnmanagedCodeSecurity]
			static extern IntPtr btCompoundCompoundCollisionAlgorithm_CreateFunc_new();
		}

		public new class SwappedCreateFunc : CollisionAlgorithmCreateFunc
		{
			internal SwappedCreateFunc(IntPtr native)
				: base(native, true)
			{
			}

			public SwappedCreateFunc()
				: base(btCompoundCompoundCollisionAlgorithm_SwappedCreateFunc_new(), false)
			{
			}

            public override CollisionAlgorithm CreateCollisionAlgorithm(CollisionAlgorithmConstructionInfo __unnamed0, CollisionObjectWrapper body0Wrap, CollisionObjectWrapper body1Wrap)
            {
                return new CompoundCompoundCollisionAlgorithm(btCollisionAlgorithmCreateFunc_CreateCollisionAlgorithm(
                    _native, __unnamed0._native, body0Wrap._native, body1Wrap._native));
            }

			[DllImport(Native.Dll, CallingConvention = Native.Conv), SuppressUnmanagedCodeSecurity]
			static extern IntPtr btCompoundCompoundCollisionAlgorithm_SwappedCreateFunc_new();
		}

		internal CompoundCompoundCollisionAlgorithm(IntPtr native)
			: base(native)
		{
		}

		public CompoundCompoundCollisionAlgorithm(CollisionAlgorithmConstructionInfo ci,
			CollisionObjectWrapper body0Wrap, CollisionObjectWrapper body1Wrap, bool isSwapped)
			: base(btCompoundCompoundCollisionAlgorithm_new(ci._native, body0Wrap._native,
				body1Wrap._native, isSwapped))
		{
		}

		[DllImport(Native.Dll, CallingConvention = Native.Conv), SuppressUnmanagedCodeSecurity]
		static extern IntPtr btCompoundCompoundCollisionAlgorithm_new(IntPtr ci, IntPtr body0Wrap, IntPtr body1Wrap, bool isSwapped);
	}
}
