# CanteenSystem
食堂采购管理系统

功能模块：

1、	用户管理

2、供应商信息管理：采购组可以对供应商的信息进行增删查改。

3、菜品信息管理：采购组录入菜品信息，包括菜品名称、单位、报价、优惠率、单价（单价=报价*优惠率）、日期（录入时自动生成）

4、	班组创建请购单：班组填写请购单信息，单据编号自动生成（编号格式：日期+第几餐）、请购人、部门自动填写，主要填写菜品名称（可模糊查询选填）、数量，报价、优惠率、单价根据所填菜品自动补全，金额（金额=单价*数量），总金额自动求出，最后提交请购单。
5、	班组可以查询自己提交的订单信息；

5、采购组审核请购单：采购组查看请购单，填选供应商，最后将采购单发送给商家。
（采购组、供应商查看订单信息）
6、验收入库，菜品到货之后根据实际到的菜品和数量创建验收单据，验收无误后保存为入库单？

7、	对账，将采购订单与入库单进行对比。

8、	单据查询：根据供应商名称、班组、日期进行单据查询。

9、价格查询：采购组可根据菜品名称对菜品历史价格进行查询。
Menu(菜单表)
Menu_id	Menu_name	Unit	Menu_Quote	Menu_Rate	Menu_Price	Inputdate	Remark
1	生菜	斤	4	0.8	3.2	2018-2-2	
2	白菜	斤	4.2	0.8	3.36	2018-2-2	
3	生菜	斤	3	0.8	2.4	2018-3-2	
4	白菜	斤	4	0.8	3.2	2018-3-2	

Order(请购单)
Order_id	Date	Department	Creater	Provider	TotalMoney	Status	Virifier	Remark
1	2018-2-3	五合一班	张三		65.6	未发送		
2	2018-4-5	长岗一班	李四		112	未发送		

MenuOrder_R(菜单—订单关系表)
R_id	Order_id	Menu_id	Quote	Rate	Price	Count	Money	Inputdate	Remark
1	1	1	4	0.8	3.2	10	32	2018-2-2	
2	1	2	4.2	0.8	3.36	10	33.6	2018-2-2	
3	2	3	3	0.8	2.4	20	48	2018-3-2	
4	2	4	4	0.8	3.2	20	64	2018-3-2	

Order2(请购单)
Order_id	Date	Department	Creater	Provider	TotalMoney	Status	Virifier	Remark
1	2018-2-3	五合一班	张三	五合菜市场	65.6	已发送	王五	
2	2018-4-5	长岗一班	李四	长岗菜市场	112	已发送	王五	

Order3（验收单）
Order_id	Date	Department	Creater	Provider	TotalMoney	Status	Virifier	Remark
1	2018-2-3	五合一班	张三	五合菜市场	78.62	已发送	王五	
2	2018-4-5	长岗一班	李四	长岗菜市场	112	已发送	王五	

MenuOrder3_R
R_id	Order_id	Menu_id	Count	Money	Remark
1	1	1	12	38.4	
2	1	2	12	40.22	
3	2	3	20	48	
4	2	4	20	64	



当前系统存在问题：
1、	当菜品表中有同名菜品时，添加订单选择菜品时发生冲突
拟解决方法：菜品表中已有菜品不能再次新增
是否已解决：是
2、	价格查询：查询某个菜品价格时，同一价格同一日期的菜品会出现多行
是否已解决：是
3、	订单提交：订单提交成功后没有将订单清空，容易导致用户将同一订单提交多次
是否已解决：是
订单提交：  订单为空时也能提交
是否已解决：是
4、	订单创建日期确定是可选？还是提交订单时自动生成？

5、	

