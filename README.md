### 基于Windows系统零部件销售系统
### Parts sales management program based on Windows platform

### 一、软件版本(Software version)：VS 2010, SQL Server 2008

不同版本兼容可能存在未知BUG。

compatible with different versions may have unknown bugs.

### 二、注意事项(Matters needing attention)

在使用前你需要将数据库附加到你的电脑上，数据库文件在 `` Component-Sell/Data `` 下。

You need to attach the database to your computer before using it. The database file is under Component-sell /data.

在运行之前你同样需要对项目内数据库连接配置进行修改。

You also need to modify the database connection configuration within the project before running it.

文件配置在 `` Component-Sell/Data_Class/SqlHelpers.cs `` 下,修改对应信息。

Configure the file under `` component-sell/Data_Class/sqlhelpers.cs `` and modify the corresponding information.

``` c#
public string strcon = "data source=GREAT;initial catalog=XSXT;integrated security=true";
```
