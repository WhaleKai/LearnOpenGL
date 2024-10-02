#version 330 core
out vec4 FragColor;

//in vec3 ourColor;
//in vec2 TexCoord;

//uniform sampler2D texture1;	// 输入读取纹理
//uniform sampler2D texture2;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main()
{
	//FragColor = vec4(ourColor, 1.0f);	//用顶点着色器的颜色设置顶点颜色
	//FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0f);	//贴图
	//FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);	//贴图
	FragColor = vec4(lightColor * objectColor, 1.0);
}