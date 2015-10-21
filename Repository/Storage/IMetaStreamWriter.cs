﻿namespace Repository.Storage
{
    public interface IMetaStreamWriter
    {
        void Write<T>(T metaObject) where T : class;
    }
}