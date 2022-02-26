# 基于Windows系统零部件销售系统

## 一、软件版本(Version)：VS 2010, SQL Server 2008

不同版本兼容可能存在未知BUG。


## 二、注意事项(Matters needing attention)

在使用前你需要将数据库附加到你的电脑上，数据库文件在 `` Component-Sell/Data `` 下。

在运行之前你同样需要对项目内数据库连接配置进行修改。

文件配置在`` Component-Sell/Data_Class/SqlHelpers.cs ``下,修改对应信息。

``` c#
public string strcon = "data source=GREAT;initial catalog=XSXT;integrated security=true";
```

## 三、效果预览
![登录](image/2.png)
![注册](image/1.png)
![主页面](image/3.png)
![订单页](image/4.png)
![支付页](image/5.png)
![系统后台](image/6.png)
![库存管理](image/7.png)
![合同审批](image/9.png)
![合同生成](image/10.png)
![合同查看](image/8.png)
![数据备份](image/11.png)
![数据恢复](image/12.png)