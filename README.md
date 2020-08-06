<p align="center">
  <span>中文</span> |  
  <a href="https://github.com/dotnetcore/natasha/tree/master/lang/english">English</a>
</p>
<p align="center"> <span>你们的反馈是我的动力，文档还有很多不足之处；</span> </p>
<p align="center"> <span> 当你看完文档之后仍然不知道如何实现你的需求，您可以查看<a href="https://github.com/dotnetcore/Natasha/blob/master/docs/FAQ.md"> FAQ </a>或者在issue中提出你的需求。</span> </p>

# Natasha 

[![Member project of .NET Core Community](https://img.shields.io/badge/member%20project%20of-NCC-9e20c9.svg)](https://github.com/dotnetcore)
[![NuGet Badge](https://buildstats.info/nuget/DotNetCore.Natasha?includePreReleases=true)](https://www.nuget.org/packages/DotNetCore.Natasha)
[![Gitter](https://badges.gitter.im/dotnetcore/natasha.svg)](https://gitter.im/dotnetcore/Natasha?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
[![Badge](https://img.shields.io/badge/link-996.icu-red.svg)](https://996.icu/#/zh_CN)
[![GitHub license](https://img.shields.io/github/license/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/blob/master/LICENSE)

&ensp;&ensp;&ensp;&ensp;基于 [Roslyn](https://github.com/dotnet/roslyn) 的 C# 动态程序集构建库，该库允许开发者在运行时使用 C# 代码构建域 / 程序集 / 类 / 结构体 / 枚举 / 接口 / 方法等，使得程序在运行的时候可以增加新的模块及功能。Natasha 集成了域管理/插件管理，可以实现域隔离，域卸载，热拔插等功能。 该库遵循完整的编译流程，提供完整的错误提示， 可自动添加引用，完善的数据结构构建模板让开发者只专注于程序集脚本的编写，兼容 stanadard2.0 / netcoreapp3.0+, 跨平台，统一、简便的链式 API。 且我们会尽快修复您的问题及回复您的 [issue](https://github.com/dotnetcore/Natasha/issues/new).   
[更多的动图展示](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/gif.md)


 ![展示](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha.gif)
<br/>

### 类库信息(Library Info)  

[![GitHub tag (latest SemVer)](https://img.shields.io/github/tag/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/releases) ![GitHub repo size](https://img.shields.io/github/repo-size/dotnetcore/Natasha.svg) [![GitHub commit activity](https://img.shields.io/github/commit-activity/m/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/commits/master) [![Codecov](https://img.shields.io/codecov/c/github/dotnetcore/natasha.svg)](https://codecov.io/gh/dotnetcore/Natasha)  

| Scan Name | Status |
|--------- |------------- |
| Document | [![wiki](https://img.shields.io/badge/wiki-ch-blue.svg)](https://natasha.dotnetcore.xyz/) |
| Lang | ![Compile](https://img.shields.io/badge/script-csharp-green.svg)|
| OS | ![Windows](https://img.shields.io/badge/os-windows-black.svg) ![linux](https://img.shields.io/badge/os-linux-black.svg) ![mac](https://img.shields.io/badge/os-mac-black.svg)|
| Rumtime | ![standard](https://img.shields.io/badge/platform-standard2.0-blue.svg) ![standard](https://img.shields.io/badge/platform-netcore3.0-blue.svg) ![standard](https://img.shields.io/badge/platform-netcore3.1-blue.svg)| 

<br/>  

### 持续构建(CI Build Status)  

| CI Platform | Build Server | Master Build  | Master Test |
|--------- |------------- |---------| --------|
| Github | linux/mac/windows | [![Build status](https://img.shields.io/github/workflow/status/dotnetcore/Natasha/.NET%20Core/master)](https://github.com/dotnetcore/Natasha/actions) ||
| Azure |  Windows |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=Windows)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) |
| Azure |  Linux |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=Linux)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) | 
| Azure |  Mac |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=macOS)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) | 


<br/>    

### 使用方法(User Api)：   

#### v4.0.0.0 版本

 - 引入 动态构建库： DotNetCore.Natasha

 - 引入 编译组件库：  
 
    - DotNetCore.Natasha.CSharpSyntax  语法组件库
    - DotNetCore.Natasha.Domain 域组件库
    - DotNetCore.Natasha.CSharpCompiler 编译组件库

- 注册组件：

  ```C#
  NatashaComponentRegister.RegistDomain<NatashaAssemblyDomain>();
  NatashaComponentRegister.RegistCompiler<NatashaCSharpCompiler>();
  NatashaComponentRegister.RegistSyntax<NatashaCSharpSyntax>();
  ```

  
 - 敲代码  
 
 <br/>  
 
#### v4.1.0.0 版本

- 引入 打包好的动态构建库： DotNetCore.Natasha.CSharp.All  

- 初始化操作：

  ```C#
  //仅仅注册组件
  NatashaInitializer.Initialize();
  //注册+预热组件 , 之后编译会更加快速
  await NatashaInitializer.InitializeAndPreheating();`
  ```
   
 - 敲代码  

 > 更多更新的参考文档：https://natasha.dotnetcore.xyz/  
 
<br/>  

 
### 开发计划  

> 目前主分支为 4.0 版本，原 3.0 版本在另个分支上。

#### 分支 NoPublish  
 
##### 4.0+ 计划  

 - [x] 暴露 roslyn 未开放的编译绑定标志给用户
 - [x] 暴露 roslyn 未开放标志 `ReferencesSupersedeLowerVersions` 给用户
 - [x] 重新设计框架，解耦域/编译器/语法树
 - [x] 增加组件管理类注入方法，使用 Emit 进行初始化构造
 - [x] 改造域管理，以支持新程序集覆盖，简化 API 调用链条
 - [x] 增加 编译基础类 / 域基础类 的功能，暴露更多的抽象功能给外界使用
 - [x] 填补框架引擎注释
 - [ ] 对 Natasha.Reverser 进行增强，增加反解结果的状态值返回
 - [ ] 基于 Natasha.Reverser 进行元数据封装，给周边项目使用。 
 - [ ] 完善 UT 测试
 - [ ] 生存下来，挣钱
 
##### 周边项目计划

 - [x] 持续支持 NatashaPad
 - [ ] 改造 [R2D](https://github.com/night-moon-studio/RuntimeToDynamic)
    - [x] 持续性能优化
    - [ ] 评估模板职责
    - [ ] 评估扩展方向
    - [ ] 评估 [NCaller](https://github.com/night-moon-studio/NCaller) 项目新需求的抽象
 - [ ] 改造 [DynmaicCache](https://github.com/night-moon-studio/DynamicCache) 
    - [x] 持续优化性能
    - [ ] 优化静态自动机
 - [ ] BTF 算法
    - [ ] 每周定时跑算法随机测试程序
    - [ ] 持续评估 `span` 序列比较方法 及 指针转换比较 的性能
    - [ ] 评估 Trie 及变种 与 BTF 算法的性能差距
 - [ ] 元数据
    - [ ] 优化性能
    - [ ] 精确解析
    - [x] 持续评估封装架构的设计方案
 - [ ] 改造 [NCaller](https://github.com/night-moon-studio/NCaller) 
    - [x] 持续优化性能
    - [ ] 私有支持
    - [ ] 设计动态变现功能和实现
    - [ ] 设计只读功能维度和实现
    - [ ] 评估 [NCaller](https://github.com/night-moon-studio/NCaller) 代理方式 和 [DynmaicCache](https://github.com/night-moon-studio/DynamicCache) 代理方式 在 R2D 模板下的异同及抽象
    - [ ] 优化静态自动机代码
 - [ ] 依赖还原库
    - [ ] NET 模块
    - [ ] NUGET 模块
    - [ ] FOLDER SCAN 模块
    - [ ] 跨平台 模块
 - [ ] 定制语法/语法糖 to Natasha
 - [ ] 持续评估 Natasha 在灵活授权模型上的应用
 - [ ] 持续搜集反编译的需求
 - [ ] 调研 JAVA to C#
 - [ ] 调研 GO to C#
 - [ ] 考虑要不要调研 PHP to C#
 - [ ] 谁能来帮我一起搞，帮我点上左边的小对号？
 
> 欢迎大家提交PR 

  <br/>  
 
  
### 性能测试
      
   - [x]  **动态调用性能测试（对照组： emit, origin）**  
     ![字段性能测试](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha%E6%80%A7%E8%83%BD%E6%B5%8B%E8%AF%951.png)
   - [x]  **动态初始化性能测试（对照组： emit, origin）**  
     ![初始化性能测试](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha%E6%80%A7%E8%83%BD%E6%B5%8B%E8%AF%952.png)
   - [x]  **内存及CPU监测截图**  
     ![内存及CPU](https://github.com/dotnetcore/Natasha/blob/master/Image/%E8%B5%84%E6%BA%90%E7%9B%91%E6%B5%8B.png) 
     

<br/>    

### Wiki审核
                             
Teng(359768998@qq.com)

<br/>

 ### 升级日志
 
 - [[2019]](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/update/2019.md)
 - [[2020]](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/update/2020.md)
 <br/>  
 
 

 ### 生态微信群  
 
为防止广告骚扰，微信群已关闭，进群请发送您的微信号到 2765968624@qq.com 并说明进群原因。
如果未及时处理，请在 issue 中提醒我，QQ我平时不上了。  (发广告的先死个妈) 
 
 
  <br/>  


  #### Natasha的动态调用模块:  已移至[【NCaller】](https://github.com/night-moon-studio/NCaller)
  #### Natasha的动态克隆模块:  已移至[【DeepClone】](https://github.com/night-moon-studio/DeepClone)  
  #### 查找树算法:  [【BTFindTreee】](https://github.com/dotnet-lab/BTFindTreee)  
  #### 快速动态缓存:  [【DynamicCache】](https://github.com/night-moon-studio/DynamicCache)  
  
<br/>
<br/>    


---------------------  


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fdotnetcore%2FNatasha.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fdotnetcore%2FNatasha?ref=badge_large)          
      

