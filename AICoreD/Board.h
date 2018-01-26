#pragma once

class Board
{
public:
	int blackCount = 16;
	int whiteCount = 16;
	bool gameOver = false;
	unsigned int blackRows[8];
	unsigned int whiteRows[8];
	const unsigned int COLUMNS[8] = { 2, 3, 5, 7, 11, 13, 17, 19 };	//A-H

	Board();
	Board(int newBlackCount, int newWhiteCount, unsigned int newBlackRows[], unsigned int newWhiteRows[]);
	bool makeMove(bool playerWhite, int oldRow, int oldColumn, int row, int column, bool dryRun);
	bool isGameOver();
	char getPieceAt(int row, int column);
};