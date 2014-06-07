using System.Collections;

public class TileMap{
	public enum moveType : byte {Open, Close, NorthFall, SouthFall, WestFall, EastFall};
	public enum tileType : byte {Void, Grass, Water};

	private moveType[,] moveTiles;
	private tileType[,] tileTypes;
	private byte[,] tileElevation;

	private int width;
	private int height;

	public TileMap(int width, int height){
		this.width = width;
		this.height = height;

		moveTiles = new moveType[width, height];
		tileTypes = new tileType[width, height];
		tileElevation = new byte[width, height];
	}

	public moveType getMoveType(int x, int y){
		if (x < 0 || y < 0 || x >= width || y >= height) {
			return moveType.Close;
		}
		return moveTiles [x, y];
	}

	public void setMoveType(int x, int y, moveType mt){
		moveTiles [x, y] = mt;
	}

	public tileType getTileType(int x, int y){
		if (x < 0 || y < 0 || x >= width || y >= height) {
			return tileType.Void;
		}
		return tileTypes [x, y];
	}

	public void setTileType(int x, int y, tileType tt) {
		tileTypes [x, y] = tt;
	}

	public byte getElevation(int x, int y){
		if (x < 0 || y < 0 || x >= width || y >= height) {
			return 0;
		}
		return tileElevation [x, y];
	}

	public void setElevation(int x, int y, byte elevation){
		tileElevation [x, y] = elevation;
	}
}
