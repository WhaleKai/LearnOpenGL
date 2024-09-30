#version 330 core
out vec4 FragColor;

//in vec3 ourColor;
//in vec2 TexCoord;

//uniform sampler2D texture1;	// �����ȡ����
//uniform sampler2D texture2;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main()
{
	//FragColor = vec4(ourColor, 1.0f);	//�ö�����ɫ������ɫ���ö�����ɫ
	//FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0f);	//��ͼ
	//FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);	//��ͼ
	FragColor = vec4(lightColor * objectColor, 1.0);
}