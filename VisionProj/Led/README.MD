## Project: Led

### 1. Abstract 摘要
处理自然光普通彩色图片,识别[数字电接点压力表](https://baike.baidu.com/item/%E6%95%B0%E6%98%BE%E7%94%B5%E6%8E%A5%E7%82%B9%E5%8E%8B%E5%8A%9B%E8%A1%A8)(HC-Y810)上的红色[LED数码管](https://baike.baidu.com/item/LED%E6%95%B0%E7%A0%81%E7%AE%A1)数值.
### 2. Function 函数说明
C++函数
- Input输入: string, 图片位置
- Output输出: string, 识别字符
- Dependence依赖: Halcon runtime X64

### 3. 设计计划
- [x] 主函数流程

  0. [ ] Pre 预处理
       
     1. [ ] ~~去噪增强~~
     2. [ ] 仿射变换到正视角->正对且水平
         ```
        1. [ ] ???用后边栅栏参考
        2. [ ] ???用黄色圆的椭圆计算参考
         ```
  1. [x] AutoRoi
      
       1.  [x] PLAN 选取黄色: 区域够大,容易选取,OK
            ```
           1. 选出黄色
           2. 膨胀腐蚀,连通区域
           3. 选择区域
           4. 找最小外接圆形
           5.  根据比例选取矩形
               1.  (为提高鲁棒性,适当增大roi有无必要?)  稍微增大了一圈
           6.  赋值给ROI
            ```
       2. [ ] PLAN 拟合圆根据比例定位: 考虑与"选取黄色"做融合特征;
            ```
          1. 边缘检测
          2. 拟合圆
          3. 根据比例标定ROI
            ```
       3. [x] ~~PLAN 选取红色:红色区域太小鲁棒性差,NG~~
          ```
          1. 选出红色
          2. 膨胀腐蚀,连通区域
          3. 选择区域
          4. 找最小外接矩形
          5. 转xld
          6. 赋值给ROI
         ```
  2. AutoOcr
    ```
    - [X] 1. PLAN: OCR助手 insert code
      - [ ] 注意兼容4位数码管情况: 已修改位数,待测试四位数各种情况;
      - [ ] ...
    ```
- [ ] 测试验证
  - [ ] 加噪add_noise
  - [ ] 扭曲变形
  - [ ] 网络上相关Led数字显示图片
  - [ ] 其他情况
  - [ ] ...


- [ ] cpp设计
  - [x] halcon导出cpp
  - [x] 按照cpp函数收入输出格式修改
  - [x] 补充注释
  - [x] 设计demo: cpp console,输入图片位置输出数字
  - 

### BUG
- 无法编译
``` 检查VS环境配置```
- 编译完成,halcon相关代码有异常
``` 检查debug配置;检查halcon lisence```
- 其他bug  ``` 提交issue```

### TODO

- [x] TODO: cpp 注释风格,函数头风格;
- [x] TODO: halcon函数头风格,统一