﻿using PCLExt.FileStorage;

using PokeD.Server.NetCore.Storage.Folders;

namespace PokeD.Server.NetCore.Storage.Files
{
    internal sealed class TempFile : BaseFile
    {
        public TempFile(string name) : base(new TempFolder().CreateFile(name, CreationCollisionOption.OpenIfExists)) { }
    }
}