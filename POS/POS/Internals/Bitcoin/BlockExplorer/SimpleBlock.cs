﻿using System;
using System.Linq;
using Lib.JSON.Linq;

namespace Info.Blockchain.API.BlockExplorer
{
    /// <summary>
    ///  Simple representation of a block
    /// </summary>
    public class SimpleBlock
    {
        public SimpleBlock(JObject b, bool? mainChain = false)
        {
            this.Height = (long)b["height"];
            this.Hash = (string)b["hash"];
            this.Time = (long)b["time"];
            this.MainChain = mainChain != null ? mainChain.Value : (bool)b["main_chain"];
        }

        /// <summary>
        /// Block height
        /// </summary>
        public long Height { get; private set; }

        /// <summary>
        /// Block hash
        /// </summary>
        public string Hash { get; private set; }

        /// <summary>
        /// Block timestamp set by the miner (unix time in seconds)
        /// </summary>
        public long Time { get; private set; }

        /// <summary>
        /// Whether the block is on the main chain
        /// </summary>
        public bool MainChain { get; private set; }
    }
}