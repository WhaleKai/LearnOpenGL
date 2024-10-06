#version 330 core
layout(location = 0) in vec3 aPos;   // λ�ñ���������λ��ֵΪ 0 
layout(location = 1) in vec3 aNormal;	// ������
//layout(location = 1) in vec3 aColor; // ��ɫ����������λ��ֵΪ 1
layout(location = 2) in vec2 aTexCoords;	//��ͼλ�ñ���������λ��ֵΪ 2

out vec3 Normal;
out vec3 FragPos;
out vec2 TexCoords; // ���һ����ͼ����
//out vec3 ourColor; // ��Ƭ����ɫ�����һ����ɫ

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat3 normalMatrix;

void main()
{
	gl_Position = projection * view * model * vec4(aPos, 1.0);
	//ourColor = aColor; // ��ourColor����Ϊ���ǴӶ�����������õ���������ɫ
	TexCoords = aTexCoords;
	Normal = normalMatrix * aNormal;
	FragPos = vec3(model * vec4(aPos, 1.0));
}