    /// <summary>
	/// Patch header describing an action for a single file path.
    /// </summary>
    [Serializable]
		    int hdrEnd = getHunks()[0].StartOffset;
		    if (h.File != this)
		    {
		    	throw new ArgumentException("Hunk belongs to another file");
		    }
		    {
		    	hunks = new List<HunkHeader>();
		    }
	    /// <summary>
		/// Returns a list describing the content edits performed on this file.
	    /// </summary>
	    /// <returns></returns>
	    public EditList ToEditList()
			hunks.ForEach(hunk => r.AddRange(hunk.ToEditList()));
	     *            first character After the "diff --git " or "diff --cc " part.
	     * @return first character After the LF at the end of the line; -1 on error.