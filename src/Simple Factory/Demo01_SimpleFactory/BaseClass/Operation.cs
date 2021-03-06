﻿namespace Demo01_SimpleFactory.BaseClass
{
    /// <summary>
    /// 算法抽象基类
    /// </summary>
    public abstract class Operation
    {
        /// <summary>
        /// 第一个运算数
        /// </summary>
        public double NumberA { get; set; }
        /// <summary>
        /// 第二个运算数
        /// </summary>
        public double NumberB { get; set; }
        /// <summary>
        /// 运算结果
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();
    }
}
