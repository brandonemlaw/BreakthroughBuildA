#pragma once
#include "stdafx.h"
#include <random>
#include "Board.h"




struct Move
{
	int value;
	short unsigned int row;
	short unsigned int col;
	short unsigned int target;
};

const unsigned int COLUMNS[8] = { 2, 3, 5, 7, 11, 13, 17, 19 };	//A-H

extern "C" __declspec(dllexport) Move __stdcall  AIGetMove(int blackCount, int whiteCount, unsigned int blackRows[], unsigned int whiteRows[], bool isWhitesTurn);

bool executeRandomGame(Board& board, bool isWhitesTurn);
void populateMoveList(Move moves[], unsigned int& moveCount, unsigned int pieceCount, unsigned int* currentPieces, unsigned int* otherPieces, unsigned short int row);
