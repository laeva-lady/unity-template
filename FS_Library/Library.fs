namespace fsControl

open UnityEngine

type Movement() =
    inherit MonoBehaviour()

    let speed: float32 = 3f

    let keysMovements =
        Map.ofList
            [ KeyCode.W, Vector3.forward
              KeyCode.A, Vector3.left
              KeyCode.S, Vector3.back
              KeyCode.D, Vector3.right ]

    member this.Update() =
        for KeyValue(key, direction) in keysMovements do
            if Input.GetKey key then
                speed * Time.deltaTime * direction |> this.transform.Translate


        ()
