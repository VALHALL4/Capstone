Shader "Custom/Holo_URP"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white"
        _Color ("Color", Color) = (1, 1, 1, 1)
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            ZWrite Off
            ColorMask RGB
            Blend SrcAlpha OneMinusSrcAlpha

            HLSLPROGRAM
            #pragma surface surf Standard alpha:fade

            struct Input
            {
                float2 uv_MainTex;
                float3 worldPos;
            };

            sampler2D _MainTex;
            fixed4 _Color;

            void surf (Input IN, inout SurfaceOutputStandard o)
            {
                fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
                o.Albedo = c.rgb * _Color.rgb;
                o.Alpha = c.a * _Color.a;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}