# Emrys.UrlUtil 
### 1、路径组合URL 
UrlUtil.BuildUrl("http://www.baidu.com","user","login");<br/>
返回:http:/www.xxxxxx.com/user/login

### 2、带参数组合  
Dictionary<string, string> dic = new Dictionary<string, string>();<br/>
dic.Add("name", "emrys");<br/>
dic.Add("age", "18");<br/>
UrlUtil.BuildUrl("http://www.xxxxxx.com", dic)<br/>
返回:http://www.xxxxxx.com?name=emrys&age=18


### 2、带参数和路径组合  
Dictionary<string, string> dic = new Dictionary<string, string>();<br/>
dic.Add("name", "emrys");<br/>
dic.Add("age", "18");<br/>
UrlUtil.BuildUrl("http://www.xxxxxx.com","user","login",dic)<br/>
返回:http://www.xxxxxx.com/user/login?name=emrys&age=18
 
