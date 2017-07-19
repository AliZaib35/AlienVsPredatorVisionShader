
Shader "Image Effects/ThermalHeatEffect"
{
	Properties 
	{
			_Color("Color",Color) = (1,1,1,1)

	}
	SubShader
	{
		

		Tags
		{
			"Queue" = "Overlay+1"
		}

		ZWrite On
		ZTest Always
		Blend One One

		
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"
			float4 _Color;

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				return o;
			}

			half4 _OverDrawColor;

			fixed4 frag(v2f i) : SV_Target
			{

				return float4(1,0.2,0,1) ;
			}

			ENDCG
		}
	}
}
