static int designerPdfViewer(int[] h, string word) {
	int maxHeight = 0;

	foreach(char c in word){
		int index = char.ToUpper(c) - 64;
		if(h[index - 1] > maxHeight)
			maxHeight = h[index-1];
	}
	
	return word.Length * maxHeight;
}
