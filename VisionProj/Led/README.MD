## Project: Led
### 函数说明
cpp函数
- Input输入: cstring, 图片位置
- Output输出: cstring, 识别字符
依赖:无

### 设计计划
- [ ] 主函数流程
  1. [ ] AutoRoi
       1. [ ] PLAN 根据颜色
          1. 选出红色
          2. 标定ROI
       2. [ ] PLAN 拟合圆根据比例定位
          1. 边缘检测
          2. 拟合圆
          3. 根据比例标定ROI
  2. AutoOcr
    - [X] 1. PLAN: OCR助手
    - [ ] ...
- [ ] 测试验证
  - [ ] 加噪add_noise
  - [ ] 扭曲变形
  - [ ] 网络上相关Led数字显示图片
  - [ ] 其他情况
  - 

- [ ] 参考
  - [ ] ihalcon例子
  - [ ] 网络上相关Led数字显示图片及实施方法

- [ ] 算法细节
  - [ ] ddd

- [ ] cpp设计
  - [ ] halcon导出cpp
  - [ ] 设计demo: cpp console,输入图片位置输出数字
  - 

### 

TODO: cpp 注释风格,函数头风格;
TODO: halcon函数头风格,统一