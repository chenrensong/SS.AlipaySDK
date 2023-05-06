# SS.AlipaySDK

[![NuGet Version](https://img.shields.io/nuget/v/ss.alipay.svg?style=flat)](https://www.nuget.org/packages?q=ss.alipay)

SS.AlipaySDK是一个基于支付宝开放平台官方SDK的项目，使用 .Net Standard 2.0开发，支持 .Net Framework 4.6.1，.Net Core 2.0及以上版本。该SDK可以帮助您自动满足支付宝能力调用过程中所需的证书校验、加签、验签、发送HTTP请求等非功能性要求。更多有关支付宝开放平台协议的内容，可前往 [支付宝开发文档](https://opendocs.alipay.com/open-v3/054kaq) 了解更多。

## 安装

您可以通过NuGet来安装SS.AlipaySDK包。NuGet是一个Visual Studio的扩展工具，可以帮助开发人员轻松获取和安装代码库。在Visual Studio中打开NuGet包管理器控制台并执行以下命令即可安装：

```sh
Install-Package SS.AlipaySDK
```

### 关于OpenAPI规范（OAS）

OpenAPI规范（OAS），是定义一个标准的、与具体编程语言无关的RESTful API的规范，您可查阅 [OAS官网](https://www.openapis.org) 了解更多。

利用支付宝提供的OpenAPI描述文件，您可以用代码生成工具来自动生成各种编程语言代码，用自动测试工具进行测试等等。

v3 SDK是基于 [OpenAPI描述文件](v3/api/openapi.yaml) 、使用 [OpenAPI Generator](https://openapi-generator.tech) 生成的。
