# UI Tween 애니메이션 연습용 어플리케이션 (Unity)
<br/>

## - 애니메이션
<img src="https://user-images.githubusercontent.com/86781939/224249947-86ce63bf-555d-4d4f-9954-a43f1a751e01.gif"  width="270" height="600" > <img src="https://user-images.githubusercontent.com/86781939/224251388-fa556561-24ce-4e9b-b0c1-a7a17212521f.gif"  width="270" height="600" > <img src="https://user-images.githubusercontent.com/86781939/224290256-9409134a-02b2-4937-8aec-c56619c7c214.gif"  width="270" height="600" >

   1. UI 크기 변경 애니메이션
   2. UI 이동 애니메이션
   3. UI 회전, 투명도 변경 애니메이션
<br/>

## - 문제 해결
```python
homeBox.LeanMoveLocal(new Vector2(0, -2000), 0.75f).setEaseInQuint().setOnComplete(resetPosition);
```
   - setOnComplete로 애니메이션이 출력된 이후 함수 호출 (UI 위치 리셋)
```python
Invoke("enableButton", 1);
```
   - Invoke로 버튼 중복 입력 방지
```python
LeanTween.value(gameObject, updateValueExampleCallback, 0f, 1f, 1f);
```
   - 캔버스에는 투명도 속성이 없기 때문에 콜백함수를 만들어서 투명도 따로 변경
<br/>

## - 참고
  - 애니메이션 에셋 - LeanTween (https://assetstore.unity.com/packages/tools/animation/leantween-3595?locale=ko-KR)
  - 애니메이션 ease 속성 - Easing Functions Cheat Sheet (https://easings.net/)
<br/>

<img src="https://img.shields.io/badge/Unity-212121?style=for-the-badge&logo=Unity&logoColor=white"><img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=Visual%20Studio&logoColor=white"><img src="https://img.shields.io/badge/C%20Sharp-239120?style=for-the-badge&logo=C%20Sharp&logoColor=white"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=GitHub&logoColor=white">
