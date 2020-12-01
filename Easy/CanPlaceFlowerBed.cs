public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0){
            return true;
        }
        if (flowerbed.Length == 1){
            return flowerbed[0] == 0;
        }
        for (int i = 0; i<flowerbed.Length; i++){
            if (flowerbed[i] == 0){
                if (i == 0 && flowerbed[i+1] == 0){
                    flowerbed[i] = 1;
                    n--;
                }
                else if(i == flowerbed.Length - 1 && flowerbed[i-1]==0){
                    flowerbed[i] = 1;
                    n--;
                }
                else if (i>0 && i<flowerbed.Length -1 && flowerbed[i-1] == 0 && flowerbed[i+1] == 0){
                    flowerbed[i] = 1;
                    n--;
                }
            }
            
            if (n==0){
                return true;
            }
        }
        return false;
    }
}