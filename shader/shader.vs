#version 330 core
layout(location = 0) in vec3 aPos;   // 位置变量的属性位置值为 0 
layout(location = 1) in vec3 aNormal;	// 法向量
//layout(location = 1) in vec3 aColor; // 颜色变量的属性位置值为 1
layout(location = 2) in vec2 aTexCoords;	//贴图位置变量的属性位置值为 2

out vec3 Normal;
out vec3 FragPos;
out vec2 TexCoords; // 输出一个贴图坐标
//out vec3 ourColor; // 向片段着色器输出一个颜色

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat3 normalMatrix;

void main()
{
	gl_Position = projection * view * model * vec4(aPos, 1.0);
	//ourColor = aColor; // 将ourColor设置为我们从顶点数据那里得到的输入颜色
	TexCoords = aTexCoords;
	Normal = normalMatrix * aNormal;
	FragPos = vec3(model * vec4(aPos, 1.0));
}