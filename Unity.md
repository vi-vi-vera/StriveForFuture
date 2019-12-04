# Unity 学习笔记

## 技巧

1. rename快捷键：F12
2. VS快捷操作快捷键：Ctrl+.（类封装属性，对属性名用快捷操作封装字段可以很方便的get和set）
3. F12看Unity源码
4. 材质球的shader：legacy shaders/Particles/**Alpha Blended**
5. 使用锚点时，按住alt键能使posx,posy不变，相对父对象位置改变
6. 删除快捷键：shift + delete
7. 在移动场景物体进行拼接的时候，按V键可以自动拼接上

## C#语言

如果类成员(字段和方法)前面没有加有修饰符的话，**默认访问权限是private**。

### 单例模式

* 唯一性
* 安全性

~~~c#
public class PlayerModel
{
    //单例模式的写法
    private static PlayerModel _instance = null;
    
    private PlayerModel()
    {
        
    }
    
    public static PlayerModel Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Player();
            }
            return _instance;
        }
    }
    //把一个人物的所有属性列举出来
    public PlayerVo player = new PlayerVo();
}
~~~

## 按键

~~~c#
if(Input.GetKeyDown(KeyCode.J))
{
    //如果按下 J键
}
~~~

## 按钮事件监听

~~~c#
btn_close.onClick.AddListener(() => gameObject.SetActive(false));
~~~

## 延迟

~~~c#
IEnumerator XXX(){
	yield return new WaitForSecond(length);
}
~~~

