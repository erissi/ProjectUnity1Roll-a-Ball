Shader "2017/Processamento"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Dano ("Dano recebido", float) = 0
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;
			float _Dano;
			fixed4 frag (v2f i) : SV_Target
			{
			//correto
			//fixed4 col = tex2D(_MainTex, i.uv);

			fixed4 col = tex2D(_MainTex, i.uv);
				//fixed4 col = tex2D(_MainTex, i.uv);

				//Deslocar material
				// just invert the colors
				//col = 1 - col;
				//col.r = 1;
				//col.g = 1;
				if(col.r < _Dano){
				col.r = _Dano;}
				return col;
			}
			ENDCG
		}
	}
}
