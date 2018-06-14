# TaxClassificationCodeCHS
中国大陆地区税收分类编码辅助类，用于按税收分类编码获取其对应的税务名称以及税务简称，目前参考标准为2018税务最新版本

## .NET版本支持
目前支持以下版本：`.NET40`、`.NET Standard 1.0`

## 快速使用
因为该类仅为辅助类，所以也就简单的两个使用方法
* `TaxClassificationCodeHelper.GetCode` 获取编码对应的税收分类编码信息
* `TaxClassificationCodeHelper.GetChildren` 获取编码对应的子类税收分类编码信息集合（包含自身）
