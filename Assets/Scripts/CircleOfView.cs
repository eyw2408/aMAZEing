using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfView : MonoBehaviour {

	//public GameObject circle;
	private float time;
	private float timeCounter;
	// Use this for initialization
	void Start () {
		//circle.GameObject.find("CircleOfView");
		time = Time.time;
		timeCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter++;
		if (Time.time <= 23.5) {	
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.01F, 0.01F, 0);
			}
		
		//} else if ((Time.time > 101 && Time.time < 139) || (Time.time > 200)) {
		//if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
		//	transform.localScale -= new Vector3(0.1F, 0.1F, 0);
		//}
		} else if (Time.time < 27.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 31.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 35.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 39.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 43.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 47.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 51.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 55.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 59.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 63.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 67.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 71.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 75.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 79.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 83.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 87.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 91.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 95.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 99.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 103.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 107.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 111.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 115.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 119.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 123.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 127.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 131.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 135.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		} else if (Time.time < 139.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 143.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 147.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 151.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 155.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 159.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 163.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 167.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		} else if (Time.time < 171.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 175.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 179.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 183.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 187.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 191.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 195.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 199.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 203.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 207.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 211.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 215.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}else if (Time.time < 219.5) {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		} else if (Time.time < 223.5) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		}
		//Debug.Log("Time----> : " + Time.time);
		//Debug.Log(">>>>>>>: " + timeCounter);
		
	}
}
