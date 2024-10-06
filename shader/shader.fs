#version 330 core
out vec4 FragColor;

//in vec3 ourColor;
in vec3 Normal;
in vec3 FragPos;
in vec2 TexCoords;

struct Material {
    sampler2D diffuse;
    sampler2D specular;
    float shininess;
}; 
struct Light {
    //vec3 position;
	vec3 direction;

    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
};

//uniform sampler2D texture1;	// 输入读取纹理
//uniform sampler2D texture2;
//uniform vec3 objectColor;
uniform vec3 viewPos;
uniform Material material;
uniform Light light;

void main()
{
	//FragColor = vec4(ourColor, 1.0f);	//用顶点着色器的颜色设置顶点颜色
	//FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0f);	//贴图
	//FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);	//贴图
	// 环境光
	vec3 ambient = light.ambient * vec3(texture(material.diffuse, TexCoords));

	// 漫反射
	vec3 norm = normalize(Normal);
	// vec3 lightDir = normalize(light.position - FragPos);
	vec3 lightDir = normalize(-light.direction);

	float diff = max(dot(norm, lightDir), 0.0);
	vec3 diffuse = light.diffuse * diff * vec3(texture(material.diffuse, TexCoords));

	//镜面反射
	vec3 viewDir = normalize(viewPos - FragPos);
	vec3 reflectDir = reflect(-lightDir, norm);
	float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
	vec3 specular = light.specular * spec * vec3(texture(material.specular, TexCoords));

	vec3 result = ambient + diffuse + specular;
	FragColor = vec4(result, 1.0);
}