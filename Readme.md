# GitHubAdvanture

## 这是啥？

​	这是一个用于GitHub多人协作教学用途的Unity项目。在Master分支中存放着一个半成品的游戏，现在需要各个Contributos来完善它。

## 如何食用？

​	先将该库克隆到本地，若是CSSTA的成员请选择Branch为Training，再使用Unity2019.3.0f5或更高版本打开它，在Sences文件夹中有六个待完成的场景，一个用于参考的场景，还有一个用与自由发挥的场景，在工程根目录下打开Taskdetail.txt，若关卡名称后被填上名字了，请不选择,请在level1-6这六个场景中剩下那些尚未被开发过的场景中选择自己想要搭建的那个，接着在Taskdetail.txt中对应的场景名字后写上自己的名字，让其他开发者不必重复搭建

- 请不要推送到Master分支中！那是为了让后人也可以拿来用

### 背景知识

请打开Sample场景

- 框架部分

  如下图所示

  ![FrameWork](https://github.com/halozxc/GithubAdvanture/blob/master/Pictures/FrameWork.png)

  每个场景都具有<font color=yellow>一个GameManager，一个Player和一个由若干个具有Walkable组件的game object组成的地图</font>,GameManager负责控制地图上机关，记录地图与玩家的基本情况，Player由PlayerController组件控制，负责控制移动与寻路(点击方块的时候会移动到那里)，Walkable组件负责标记与连接路径。

  

  - 地图的搭建

  如下图所示，以cube（11）为例

![sample](https://github.com/halozxc/GithubAdvanture/blob/master/Pictures/Level1.png)



- 寻路部分

​	我们可以看到，<font color=Grenn>Cube(10)</font>具有一个Walkable组件，在这个组件下，我们可以看到一个PossiblePath属性，里面有两个元素（Element0和Element1）,每个元素下面还有Target和Active两个属性，从图中我们可以很容易看到<font color=Grenn>Cube(10)</font>与<font color=Grenn>Cube(11)</font>和<font color=Grenn>Cube(12)</font>毗邻，于是，我们可以认为<font color=Grenn>Cube(10)</font><font color=red>可以直达</font><font color=Grenn>Cube(11)</font>与<font color=Grenn>Cube(12)</font>这两个方块，所以我们在<font color=b728bc>Element0.target</font>与<font color=b728bc>Element1.target</font>中填（拖）入了<font color=Grenn>Cube(11)</font>与<font color=Grenn>Cube(12)</font>，使方块之间相互连接起来，形成路径，现在可以运行这个场景，点击任意一个方块，看场景中的白球是否移动到刚刚被点击的方块之上。如果已经明白了以上所说的操作后，请思考一下Cube与Cube(27)的PossiblePath具有多少个元素？

那么，背景知识就介绍到这里啦，在具体的场景搭建中我会给出进一步的说明的

### Level1具体任务解释

1. 请在层级面板找到<font color=grenn>Player</font>，为其添加PlayerController组件，并将<font color=grenn>indicator</font> 拖到PlayerController组件下的<font color=b728bc>indicator</font>属性中
2. 将<font color=grenn>Player</font>拖到<font color=green>GameManager</font>的GameManager组件的<font color=b728bc>Player</font>属性中，
3. 根据背景知识所讲述的操作，完成地图的搭建。
4. 找到 <font color=green>Cube(27)</font>,在其JumpScene组件的<font color=b728bc>Next Scene</font>属性中，填入"Level2"
5. 添加一个空物体，并为其添加AudioSource组件，添加的AudioClip为"The voice in my heart"
6. 点击运行，看小球是否可以正常运行

### Level2具体任务解释

1. 请在层级面板找到<font color=grenn>Player</font>，为其添加PlayerController组件，并将<font color=grenn>indicator</font> 拖到PlayerController组件下的<font color=b728bc>indicator</font>属性中
2. 将<font color=grenn>Player</font>拖到<font color=green>GameManager</font>的GameManager组件的<font color=b728bc>Player</font>属性中，
3. 根据背景知识所讲述的操作，完成地图的搭建。（平路的部分已经搭建完成，根据Game视图可知，<font color=grenn>Cube(16)</font>与<font color=green>Cube(12)</font>是相通的，需要将两者连接起来）
4. 找到 <font color=green>Cube(27)</font>,在其JumpScene组件的<font color=b728bc>Next Scene</font>属性中，填入"Level3"
5. 添加一个空物体，并为其添加AudioSource组件，添加的AudioClip为"The voice in my heart"
6. 点击运行，看小球是否可以正常运行

### Level3具体任务解释

1. 请在层级面板找到<font color=grenn>Player</font>，为其添加PlayerController组件，并将<font color=grenn>indicator</font> 拖到PlayerController组件下的<font color=b728bc>indicator</font>属性中
2. 将<font color=grenn>Player</font>拖到<font color=green>GameManager</font>的GameManager组件的<font color=b728bc>Player</font>属性中，
3. 根据背景知识所讲述的操作，完成地图的搭建。（平路的部分已经搭建完成，根据Game视图可知，<font color=grenn>Cube(16)</font>与<font color=green>Cube(12)</font>是相通的，需要将两者连接起来）
4. 找到 <font color=green>Cube(27)</font>,在其JumpScene组件的<font color=b728bc>Next Scene</font>属性中，填入"Level3"
5. 添加一个空物体，并为其添加AudioSource组件，添加的AudioClip为"The voice in my heart"
6. 点击运行，看小球是否可以正常运行