            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }

            {
                {
                }
            }
                {
                }
                {
                }
        public static byte[] GetSelectedLinesAsNewPatch(GitModule module, string newFileName, string text, int selectionPosition, int selectionLength, Encoding fileContentEncoding, bool reset, byte[] filePreabmle)

            {
            }
            {
            }

            ChunkList selectedChunks = ChunkList.FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreabmle, fileContentEncoding);
            {
            }

            {
            }
            {
            }
            {
            }

            {
            }
                {
                }
            {
            }
                    {
                    }
                    {
                    }

                    {
                    }
                    {
                    }

            {
            }

            {
            }

            {
            }

            {
            }
            {
            }
                    {
                    }
                    {
                    }

            {
            }

            {
            }

            {
            }
            {
            }
        private int _startLine;
        private List<SubChunk> _subChunks = new List<SubChunk>();
        private SubChunk _currentSubChunk = null;
                if (_currentSubChunk == null)
                    _currentSubChunk = new SubChunk();
                    _subChunks.Add(_currentSubChunk);

                return _currentSubChunk;
            {
            }
            {
            }
            {
                _currentSubChunk = null; // start new SubChunk
            }
            {
            }
            {
            }
            return int.TryParse(header, out _startLine);
            {
            }

                    {
                    }
                    {
                    }
                        {
                        }
                        {
                        }
                    {
                    }
        public static Chunk FromNewFile(GitModule module, string fileText, int selectionPosition, int selectionLength, bool reset, byte[] filePreabmle, Encoding fileContentEncoding)
            result._startLine = 0;
            {
            }
            {
            }
            {
            }
                string preamble = i == 0 ? new string(fileContentEncoding.GetChars(filePreabmle)) : string.Empty;

                {
                }
                            PatchLine lastNotSelectedLine = result.CurrentSubChunk.RemovedLines.LastOrDefault(l => !l.Selected);

                {
                }

            foreach (SubChunk subChunk in _subChunks)
            {
            }
            diff = "@@ -" + _startLine + "," + removedCount + " +" + _startLine + "," + addedCount + " @@".Combine("\n", diff);

            {
            }
            {
            }

                    {
                    }

        public static ChunkList FromNewFile(GitModule module, string text, int selectionPosition, int selectionLength, bool reset, byte[] filePreabmle, Encoding fileContentEncoding)
            Chunk chunk = Chunk.FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreabmle, fileContentEncoding);
            {
            }
